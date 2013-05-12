using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransEfficiencySuite.Models;

namespace TransEfficiencySuite.Helpers
{
    public class SignComputation
    {
        public static string TotalPostLength(string classification, string height, string isDiamond)
        {
            double signPostLength = 3.5;

            if (classification.Equals("0"))
            {
                signPostLength += 7;
            }
            else if (classification.Equals("1"))
            {
                signPostLength += 7;
            }
            else if (classification.Equals("2"))
            {
                signPostLength += 6;
            }

            if (isDiamond.Equals("true"))
            {
                signPostLength += Math.Round(Math.Pow(Math.Pow(double.Parse(height)/12,2)*2,.5),2); //(H^2+H^2)^0.5
            }

            else
            {
                signPostLength += double.Parse(height)/12;
            }

            return signPostLength.ToString();
        }

        public static string SignPostType(string area, string height, string classification, string isDiamond)
        {
            double signCentroid = 0;

            if (classification.Equals("0"))
            {
                signCentroid += 7;
            }
            else if (classification.Equals("1"))
            {
                signCentroid += 7;
            }
            else if (classification.Equals("2"))
            {
                signCentroid += 6;
            }

            if (bool.Parse(isDiamond))
                signCentroid += Math.Round(Math.Pow(Math.Pow(double.Parse(height) / 12, 2) * 2, .5)/2, 2); //[(H^2+H^2)^0.5]/2
            else
                signCentroid += (double.Parse(height) / 12) / 2;

            if (double.Parse(area) * -1.19 + 19.5 >= signCentroid)
            {
                return "Type 2";
            }
            else if (double.Parse(area) * -0.65 + 18.9 >= signCentroid)
            {
                return "Type 3";
            }
            else if (double.Parse(area) * -1.7 + 45.8 >= signCentroid)
            {
                return "Type 4";
            }
            else
                return "Type 6";

        }

    }
}