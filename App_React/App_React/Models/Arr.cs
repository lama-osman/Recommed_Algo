using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_React.Models
{
    public class Arr
    {
        int[] user;
        int[][] matrix;

        public Arr(int[] user, int[][] matrix)
        {
            this.User = user;
            this.Matrix = matrix;
        }

        public Arr() { }
        public int[] User { get => user; set => user = value; }
        public int[][] Matrix { get => matrix; set => matrix = value; }
    }
}