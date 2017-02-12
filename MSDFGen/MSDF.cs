﻿using System;
using System.Numerics;
using System.Collections.Generic;

using CSGL.Math;
using CSGL.Graphics;

namespace MSDFGen {
    struct MultiDistance {
        public double r;
        public double g;
        public double b;
        public double med;
    }

    public static partial class MSDF {
        static bool PixelClash(Color3 a, Color3 b, double threshold) {
            bool aIn = ((a.r > .5f) ? 1 : 0) + ((a.g > .5f) ? 1 : 0) + ((a.b > .5f) ? 1 : 0) >= 2;
            bool bIn = ((b.r > .5f) ? 1 : 0) + ((b.g > .5f) ? 1 : 0) + ((b.b > .5f) ? 1 : 0) >= 2;
            if (aIn != bIn) return false;

            if ((a.r > .5f && a.g > .5f && a.b > .5f) ||
                (a.r < .5f && a.g < .5f && a.b < .5f) ||
                (b.r > .5f && b.g > .5f && b.b > .5f) ||
                (b.r < .5f && b.g < .5f && b.b < .5f))
                return false;

            float aa, ab, ba, bb, ac, bc;

            if ((a.r > .5f) != (b.r > .5f) &&
                (a.r < .5f) != (b.r < .5f)) {
                aa = a.r;
                ba = b.r;
                if ((a.g > .5f) != (b.g > .5f) &&
                    (a.g < .5f) != (b.g < .5f)) {
                    ab = a.g;
                    bb = b.g;
                    ac = a.b;
                    bc = b.b;
                } else if ((a.b > .5f) != (b.b > .5f) &&
                    (a.b < .5f) != (b.b < .5f)) {
                    ab = a.b;
                    bb = b.b;
                    ac = a.g;
                    bc = b.g;
                } else
                    return false;
            } else if ((a.g > .5f) != (b.g > .5f) &&
                (a.g < .5f) != (b.g < .5f)  &&
                (a.b > .5f) != (b.b > .5f) &&
                (a.b < .5f) != (b.b < .5f)) {
                aa = a.g;
                ba = b.g;
                ab = a.b;
                bb = b.b;
                ac = a.r;
                bc = b.r;
            } else
                return false;
            return (Math.Abs(aa - ba) >= threshold) &&
                (Math.Abs(ab - bb) >= threshold) &&
                Math.Abs(ac - .5f) >= Math.Abs(bc - .5f);
        }

        struct Clash {
            public int x;
            public int y;
        }

        static void ErrorCorrection(Bitmap<Color3> output, Vector2 threshold) {
            List<Clash> clashes = new List<Clash>();
            int w = output.Width;
            int h = output.Height;

            for (int y = 0; y < h; y++) {
                for (int x = 0; x < w; x++) {
                    if ((x > 0 && PixelClash(output[x, y], output[x-1, y], threshold.X)) ||
                        (x < w - 1 && PixelClash(output[x, y], output[x + 1, y], threshold.X)) ||
                        (y > 0 && PixelClash(output[x, y], output[x, y - 1], threshold.Y)) ||
                        (y < h - 1 && PixelClash(output[x, y], output[x, y + 1], threshold.Y))) {

                        clashes.Add(new Clash { x = x, y = y });
                    }
                }
            }

            for (int i = 0; i < clashes.Count; i++) {
                Color3 pixel = output[clashes[i].x, clashes[i].y];
                float med = Median(pixel.r, pixel.g, pixel.b);
                pixel.r = med;
                pixel.g = med;
                pixel.b = med;
                output[clashes[i].x, clashes[i].y] = pixel;
            }
        }

        static float Median(float a, float b, float c) {
            return Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c));
        }

        static double Median(double a, double b, double c) {
            return Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c));
        }

        public static void GenerateSDF(Bitmap<float> output, Shape shape, Rectangle region, double range, Vector2 scale) {
            int contourCount = shape.Contours.Count;
            List<int> windings = new List<int>(contourCount);

            for (int i = 0; i < contourCount; i++) {
                windings.Add(shape.Contours[i].Winding);
            }

            int xStart = Math.Min(Math.Min(0, (int)region.Left), output.Width);
            int yStart = Math.Min(Math.Max(0, (int)region.Top), output.Height);
            int xEnd = Math.Min(Math.Max(0, (int)region.Right), output.Width);
            int yEnd = Math.Min(Math.Max(0, (int)region.Bottom), output.Height);

            {
                double[] contourSD = new double[contourCount];

                for (int y = yStart; y < yEnd; y++) {
                    int row = shape.InverseYAxis ? output.Height - y - 1 : y;
                    for (int x = xStart; x < xEnd; x++) {
                        double dummy;
                        Vector2 p = new Vector2(x + 0.5f, y + 0.5f) / scale;
                        double negDist = -SignedDistance.Infinite.distance;
                        double posDist = SignedDistance.Infinite.distance;
                        int winding = 0;

                        for (int i = 0; i < contourCount; i++) {
                            Contour contour = shape.Contours[i];
                            SignedDistance minDistance = new SignedDistance(-1e240, 1);

                            for (int j = 0; j < contour.Edges.Count; j++) {
                                EdgeSegment edge = contour.Edges[j];
                                SignedDistance distance = edge.GetSignedDistance(p, out dummy);
                                if (distance < minDistance) {
                                    minDistance = distance;
                                }
                            }

                            contourSD[i] = minDistance.distance;
                            if (windings[i] > 0 && minDistance.distance >= 0 && Math.Abs(minDistance.distance) < Math.Abs(posDist)) {
                                posDist = minDistance.distance;
                            }

                            if (windings[i] < 0 && minDistance.distance <= 0 && Math.Abs(minDistance.distance) < Math.Abs(negDist)) {
                                negDist = minDistance.distance;
                            }
                        }

                        double sd = SignedDistance.Infinite.distance;

                        if (posDist >= 0 && Math.Abs(posDist) <= Math.Abs(negDist)) {
                            sd = posDist;
                            winding = 1;
                            for (int i = 0; i < contourCount; i++) {
                                if (windings[i] > 0 && contourSD[i] > sd && Math.Abs(contourSD[i]) < Math.Abs(negDist)) {
                                    sd = contourSD[i];
                                }
                            }
                        } else if (negDist <= 0 && Math.Abs(negDist) <= Math.Abs(posDist)) {
                            sd = negDist;
                            winding = -1;
                            for (int i = 0; i < contourCount; i++) {
                                if (windings[i] < 0 && contourSD[i] < sd && Math.Abs(contourSD[i]) < Math.Abs(posDist)) {
                                    sd = contourSD[i];
                                }
                            }
                        }

                        for (int i = 0; i < contourCount; i++) {
                            if (windings[i] != winding && Math.Abs(contourSD[i]) < Math.Abs(sd)) {
                                sd = contourSD[i];
                            }
                        }

                        output[x, row] = (float)(sd / range) + 0.5f;
                    }
                }
            }
        }

        struct EdgePoint {
            public SignedDistance minDistance;
            public EdgeSegment nearEdge;
            public double nearParam;
        }

        public static void GenerateMSDF(Bitmap<Color3> output, Shape shape, Rectangle region, double range, Vector2 scale, double edgeThreshold) {
            int contourCount = shape.Contours.Count;
            List<int> windings = new List<int>(contourCount);
            for (int i = 0; i < shape.Contours.Count; i++) {
                windings.Add(shape.Contours[i].Winding);
            }

            int xStart = Math.Min(Math.Min(0, (int)region.Left), output.Width);
            int yStart = Math.Min(Math.Max(0, (int)region.Top), output.Height);
            int xEnd = Math.Min(Math.Max(0, (int)region.Right), output.Width);
            int yEnd = Math.Min(Math.Max(0, (int)region.Bottom), output.Height);

            MultiDistance[] contourSD = new MultiDistance[contourCount];

            for (int y = yStart; y < yEnd; y++) {
                int row = shape.InverseYAxis ? output.Height - y - 1 : y;
                for (int x = xStart; x < xEnd; x++) {
                    Vector2 p = new Vector2(x + 0.5f, y + 0.5f) / scale;

                    EdgePoint sr = new EdgePoint {
                        minDistance = new SignedDistance(-1e240, 1)
                    };
                    EdgePoint sg = new EdgePoint {
                        minDistance = new SignedDistance(-1e240, 1)
                    };
                    EdgePoint sb = new EdgePoint {
                        minDistance = new SignedDistance(-1e240, 1)
                    };

                    double d = Math.Abs(SignedDistance.Infinite.distance);
                    double negDist = -SignedDistance.Infinite.distance;
                    double posDist = SignedDistance.Infinite.distance;
                    int winding = 0;

                    for (int i = 0; i < contourCount; i++) {
                        Contour contour = shape.Contours[i];
                        EdgePoint r = new EdgePoint {
                            minDistance = new SignedDistance(-1e240, 1)
                        };
                        EdgePoint g = new EdgePoint {
                            minDistance = new SignedDistance(-1e240, 1)
                        };
                        EdgePoint b = new EdgePoint {
                            minDistance = new SignedDistance(-1e240, 1)
                        };

                        for (int j = 0; j < contour.Edges.Count; j++) {
                            EdgeSegment edge = contour.Edges[j];
                            double param;

                            SignedDistance distance = edge.GetSignedDistance(p, out param);
                            if ((edge.Color & EdgeColor.Red) == EdgeColor.Red && distance < r.minDistance) {
                                r.minDistance = distance;
                                r.nearEdge = edge;
                                r.nearParam = param;
                            }
                            if ((edge.Color & EdgeColor.Green) == EdgeColor.Green && distance < g.minDistance) {
                                g.minDistance = distance;
                                g.nearEdge = edge;
                                g.nearParam = param;
                            }
                            if ((edge.Color & EdgeColor.Blue) == EdgeColor.Blue && distance < b.minDistance) {
                                b.minDistance = distance;
                                b.nearEdge = edge;
                                b.nearParam = param;
                            }
                        }

                        if (r.minDistance < sr.minDistance) sr = r;
                        if (g.minDistance < sg.minDistance) sg = g;
                        if (b.minDistance < sb.minDistance) sb = b;

                        double medMinDistance = Math.Abs(Median(r.minDistance.distance, g.minDistance.distance, b.minDistance.distance));

                        if (medMinDistance < d) {
                            d = medMinDistance;
                            winding = -windings[i];
                        }

                        if (r.nearEdge != null) {
                            r.nearEdge.DistanceToPseudoDistance(ref r.minDistance, p, r.nearParam);
                        }
                        if (g.nearEdge != null) {
                            g.nearEdge.DistanceToPseudoDistance(ref g.minDistance, p, g.nearParam);
                        }
                        if (b.nearEdge != null) {
                            b.nearEdge.DistanceToPseudoDistance(ref b.minDistance, p, b.nearParam);
                        }

                        medMinDistance = Median(r.minDistance.distance, g.minDistance.distance, b.minDistance.distance);

                        contourSD[i].r = r.minDistance.distance;
                        contourSD[i].g = g.minDistance.distance;
                        contourSD[i].b = b.minDistance.distance;
                        contourSD[i].med = medMinDistance;

                        if (windings[i] > 0 && medMinDistance >= 0 && Math.Abs(medMinDistance) < Math.Abs(posDist)) {
                            posDist = medMinDistance;
                        }
                        if (windings[i] < 0 && medMinDistance <= 0 && Math.Abs(medMinDistance) < Math.Abs(negDist)) {
                            negDist = medMinDistance;
                        }
                    }

                    if (sr.nearEdge != null) sr.nearEdge.DistanceToPseudoDistance(ref sr.minDistance, p, sr.nearParam);
                    if (sg.nearEdge != null) sg.nearEdge.DistanceToPseudoDistance(ref sg.minDistance, p, sg.nearParam);
                    if (sb.nearEdge != null) sb.nearEdge.DistanceToPseudoDistance(ref sb.minDistance, p, sb.nearParam);

                    MultiDistance msd = new MultiDistance {
                        r = SignedDistance.Infinite.distance,
                        g = SignedDistance.Infinite.distance,
                        b = SignedDistance.Infinite.distance,
                        med = SignedDistance.Infinite.distance,
                    };

                    if (posDist >=0 && Math.Abs(posDist) <= Math.Abs(negDist)) {
                        msd.med = SignedDistance.Infinite.distance;
                        winding = 1;
                        for (int i = 0; i < contourCount; i++) {
                            if (windings[i] > 0 && contourSD[i].med > msd.med && Math.Abs(contourSD[i].med) < Math.Abs(negDist)) {
                                msd = contourSD[i];
                            }
                        }
                    } else if (negDist <= 0 && Math.Abs(negDist) <= Math.Abs(posDist)) {
                        msd.med = -SignedDistance.Infinite.distance;
                        winding = -1;
                        for (int i = 0; i < contourCount; i++) {
                            if (windings[i] < 0 && contourSD[i].med < msd.med && Math.Abs(contourSD[i].med) < Math.Abs(posDist)) {
                                msd = contourSD[i];
                            }
                        }
                    }

                    for (int i = 0; i < contourCount; i++) {
                        if (windings[i] != winding && Math.Abs(contourSD[i].med) < Math.Abs(msd.med)) {
                            msd = contourSD[i];
                        }
                    }

                    if (Median(sr.minDistance.distance, sg.minDistance.distance, sb.minDistance.distance) == msd.med) {
                        msd.r = sr.minDistance.distance;
                        msd.g = sg.minDistance.distance;
                        msd.b = sb.minDistance.distance;
                    }

                    output[x, row] = new Color3((float)(msd.r / range) + 0.5f, (float)(msd.g / range) + 0.5f, (float)(msd.b / range) + 0.5f);
                }
            }
        }
    }
}
