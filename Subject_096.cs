using System;

namespace Hot100
{
    /// <summary>
    /// 98. 验证二叉搜索树
    /// https://leetcode-cn.com/problems/validate-binary-search-tree/
    /// </summary>
    class Subject_098 : ISubject
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
