namespace LeetCode_4
{
    internal class Program
    {
        public void MoveZeroes(int[] nums)
        {
            int l = 0;

            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    int temp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = temp;
                    l++;
                }
            }

        }

        public int LengthOfLastWord(string s)
        {
            string answer;

            string[] strings = s.Split(' ');
            for (int i = strings.Length - 1; i >= 0; i -= 1)
            {
                if (strings[i] != "")
                {
                    return strings[i].Length;
                }
            }
            return 0;
        }

        public void ReverseString(char[] s)
        {
            int r = s.Length - 1;
            for (int l = 0; l < s.Length / 2; l++)
            {
                char temp = s[l];
                s[l] = s[r];
                s[r] = temp;
                r -= 1;
            }

        }

        public int MajorityElement(int[] nums)
        {
            int target = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int n;

            if (nums.Length % 2 == 0)
            {
                n = nums.Length;
            }
            else
            {
                n = nums.Length + 1;
            }

            foreach (int num in nums)
            {
                if (!dic.Keys.Contains(num))
                {
                    dic[num] = 1;
                }
                else
                {
                    dic[num]++;
                }
                if (dic[num] == n / 2)
                {
                    target = num;
                }
            }
            return target;
        }

        public bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(n);
            while (n != 1)
            {
                string s = n.ToString();
                n = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    n += Convert.ToInt32(Char.GetNumericValue(s, i) * Char.GetNumericValue(s, i));
                }
                if (hs.Contains(n))
                {
                    return false;
                }

                hs.Add(n);

            }
            return true;
        }
    }
}
