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

        public bool IsValidBST(TreeNode root)
        {

            return isValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool isValidBST(TreeNode node, long lower, long upper)
        {
            if (node == null)
            {
                return true;
            }
            if (node.val <= lower || node.val >= upper)
            {
                return false;
            }
            return isValidBST(node.left, lower, node.val) && isValidBST(node.right, node.val, upper);
        }

    }
}
