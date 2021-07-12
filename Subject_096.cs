using System;

namespace Hot100
{
    /// <summary>
    /// 96. 不同的二叉搜索树
    /// https://leetcode-cn.com/problems/unique-binary-search-trees/
    /// </summary>
    class Subject_096 : ISubject
    {
        public void Test()
        {
            throw new NotImplementedException();
        }

        public int NumTrees(int n)
        {
            long C = 1;
            for (int i = 0; i < n; ++i)
            {
                C = C * 2 * (2 * i + 1) / (i + 2);
            }
            return (int)C;

          

        }
    }
}
