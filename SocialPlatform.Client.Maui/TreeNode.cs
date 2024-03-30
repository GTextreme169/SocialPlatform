namespace Mumblent;

public class TreeNode<T> : TreeNode
{
    public T? Value;
}

public class TreeNode
{
    public List<TreeNode> Nodes = new List<TreeNode>();
    public string Text = string.Empty;
    public System.Drawing.Color BackColor;

    public void Remove()
    {
        Nodes.Clear();
        Text += " (removed)";
    }
}