using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App_React.Models;

namespace App_React.Controllers
{
    public class RecommendationController : ApiController
    {
        Recommendations R = new Recommendations();

        public List<int> Post([FromBody] Arr r)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < r.Matrix.Length; i++)
            {
                List<int> res = R.SimilarityScore(r.Matrix[i], r.User);
                if (res != null)
                {
                    foreach (var item in res)
                    {
                        if (!result.Contains(item))
                        {
                            result.Add(item);
                        }

                    }
                }
            }
            return result;
        }
    }
}
