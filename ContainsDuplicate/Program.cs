using System;
using System.Collections.Generic;
using System.Linq;

/* * ---------------------------------------------------------
 * TEST SANDBOX : ContainsDuplicate
 * ---------------------------------------------------------
 */

var sol = new Solution();

// --- ZONE DE TEST ---
// int[] nums = {1, 2, 3, 1};
// Console.WriteLine($"Resultat: {sol.ContainsDuplicate(nums)}");


// --- TA SOLUTION LEETCODE ---
public class Solution {
    public bool hasDuplicateNaze(int[] nums) {
        
        foreach(var val in nums){
            var counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(val == nums[i])
                {
                    counter++;
                    if(counter > 1)
                        return true;
                }
            }
        }
        return false;
    }
     public bool hasDuplicateGood(int[] nums) {
        //Utilisation des hashset, aide de gémini, premiere fois que je use.
        var vus = new HashSet<int>();
        foreach(var val in nums){
            if(vus.Contains(val))
                return true;
            vus.Add(val);
        }
        return false;
        
    }
}


// --- STRUCTURES DE DONNÉES (Linked List & Trees) ---
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
