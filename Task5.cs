namespace Task5;
public class Task5 { 
    public static bool IsSubsequence(string s, string t)
    {   int k = 0;
        int j = 0;
        int flag = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while (j < t.Length)
            { if (s[i] == t[j])
                { 
                    flag = 1;
                    j++;
                    break;
                }
                j++;
            }
            if (flag == 0)
                return false;
            flag = 0;
        }
        return true;
    }

}
