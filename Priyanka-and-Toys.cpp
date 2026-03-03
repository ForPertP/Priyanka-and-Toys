#include <bits/stdc++.h>

using namespace std;

string ltrim(const string &);
string rtrim(const string &);
vector<string> split(const string &);

/*
 * Complete the 'toys' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY w as parameter.
 */

int toys(vector<int> w)
{
    sort(w.begin(), w.end());
    
    int count = 0;
    int limit = INT_MIN;
    
    for (int weight : w)
    {
        if (weight > limit)
        {
            count++;
            limit = weight + 4;
        }
    }
    
    return count;
}
