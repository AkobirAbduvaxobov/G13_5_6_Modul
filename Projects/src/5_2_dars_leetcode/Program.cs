namespace _5_2_dars_leetcode;

internal class Program
{
    static void Main(string[] args)
    {
        string res = "Qovun";
        Console.WriteLine(res.ToArray().Reverse().ToString());

    }


}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return null;
    }

    public string GetValuesAsString(ListNode lN)
    {
        var res = string.Empty;
        while(lN != null)
        {
            res += lN.val;
            lN = lN.next;
        }

        return res.ToArray().Reverse().ToString();
    }

    



}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}