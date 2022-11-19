using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208.Implement_Trie__Prefix_Tree_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TreeNode
    {
        public string val;
        public List<TreeNode> children;
        public TreeNode(string val = "")
        {
            this.val = val;
            this.children = new List<TreeNode>();
        }
    }

    public class Trie
    {
        TreeNode root;
        public Trie()
        {
            root = new TreeNode();
        }

        public void Insert(string word)
        {
            TreeNode parent = root;
            List<TreeNode> childrenOfP = parent.children;

            if (childrenOfP.Count == 0)
            {
                childrenOfP.Add(new TreeNode(word));
                return;
            }

            TreeNode foundP = FindParent(root, word);
            if (foundP == null)
            {
                childrenOfP.Add(new TreeNode(word));
            }
            else
            {
                if (foundP.val != word)
                {
                    foundP.children.Add(new TreeNode(word));
                }
            }
        }

        public TreeNode FindParent(TreeNode node, string word)
        {
            foreach (TreeNode n in node.children)
            {
                if (n.val.StartsWith(word))
                {
                    TreeNode foundP = FindParent(n, word);
                    if (foundP == null)
                    {
                        return n;
                    }
                    else
                    {
                        return foundP;
                    }
                }
            }
            return null;
        }

        public bool Search(string word)
        {
            return RecurSearch(root, word);
        }

        public bool RecurSearch(TreeNode node, string word)
        {
            // base case for found
            if (node.val == word)
            {
                return true;
            }

            foreach (TreeNode n in node.children)
            {
                if (n.val.StartsWith(word))
                {
                    return RecurSearch(n, word);
                }
            }

            return false;
        }

        public bool StartsWith(string prefix)
        {
            return RecurStartsWith(root, prefix);
        }

        public bool RecurStartsWith(TreeNode node, string prefix)
        {
            // base case for found
            if (node.val.StartsWith(prefix))
            {
                return true;
            }

            foreach (TreeNode n in node.children)
            {
                if (RecurStartsWith(n, prefix))
                {
                    return true;
                }
            }

            return false;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
