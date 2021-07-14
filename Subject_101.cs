using System;

namespace Hot100
{
    /// <summary>
    /// 101. 对称二叉树
    /// https://leetcode-cn.com/problems/symmetric-tree/
    /// </summary>
    class Subject_101 : ISubject
    {
        public void Test()
        {
            throw new NotImplementedException();
        }

        public bool IsSymmetric(TreeNode root)
        {
            return check(root, root);
        }

        public bool check(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            return p.val == q.val && check(p.left, q.right) && check(p.right, q.left);
        }

  
    }
}
