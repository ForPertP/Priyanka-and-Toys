using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'toys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY w as parameter.
     */

    public static int toys(List<int> w)
    {
        w.Sort();
        
        int count = 0;
        int limit = int.MinValue;
        
        foreach (int weight in w)
        {
            if (weight > limit)
            {
                count++;
                limit = weight + 4;
            }
        }
        
        return count;
    }
}

