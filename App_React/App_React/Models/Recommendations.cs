using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_React.Models
{
    public class Recommendations
    {
        public Recommendations() { }

        public List<int> SimilarityScore(int[] vector, int[] user)
        {
            List<int> similarArr = new List<int>();
            List<int> differentArr = new List<int>();

            if (vector.Length >= user.Length)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    int res = user.Contains(vector[i]) ? vector[i] : 0;
                    if (res != 0) similarArr.Add(res);
                    else differentArr.Add(vector[i]);                  
                  
                }

                float score = (similarArr.Count / (float)vector.Length) * (similarArr.Count / (float)user.Length);
                if (score >= 0.5)
                {
                    if (differentArr.Count != 0) { return differentArr; }
                    else return null;
                }
                else { return null; }
            }
            else { return null; }
        }




    }
}