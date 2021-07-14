using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hot100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ISubject, Subject_101>();
            var provider = services.BuildServiceProvider();
            var subject = provider.GetService<ISubject>();
            subject.Test();
            Console.ReadLine();
        }

        public void Print(IList<IList<int>> list) {
            var left = list.Count * 2 - 1;
            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine(MakeLeftSpace(list.Count * 2 - 1));
                for (int j = 0; j < list[i].Count; j++)
                {

                }
            }
        }

        public string MakeLeftSpace(int left) {
            var sb = new StringBuilder();
            for (int i = 0; i < left; i++)
            {
                sb.Append(" ");
                
            }
            return sb.ToString();
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            else
            {
                var queue = new Queue();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    var item = new List<int>();
                    int size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var node = (TreeNode)queue.Dequeue();
                        item.Add(node.val);
                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                    result.Add(item);
                }
                return result;
            }
        }

    }
}
