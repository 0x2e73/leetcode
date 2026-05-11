using System;
using System.Collections.Generic;
using System.Linq;

/* * ---------------------------------------------------------
 * TEST SANDBOX : two-sum
 * ---------------------------------------------------------
 */

var sol = new Solution();

// --- ZONE DE TEST ---
// int[] nums = {1, 2, 3, 1};
// Console.WriteLine($"Resultat: {sol.ContainsDuplicate(nums)}");


// --- TA SOLUTION LEETCODE ---
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return new int[] { };

    }
}



// --- STRUCTURES DE DONNÉES (Linked List & Trees) ---
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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
