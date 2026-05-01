using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

/* * ---------------------------------------------------------
 * TEST SANDBOX : valid-anagram
 * ---------------------------------------------------------
 */

var sol = new Solution();

// --- ZONE DE TEST ---
// int[] nums = {1, 2, 3, 1};
// Console.WriteLine($"Resultat: {sol.ContainsDuplicate(nums)}");


// --- TA SOLUTION LEETCODE ---
public class Solution {
    public bool IsAnagramBaseSolution(string s, string t) {
        if(s.Length != t.Length)
            return false;

        string sAlph = String.Concat(s.OrderBy(s => s));
        string tAlph = String.Concat(t.OrderBy(t => t));
        return sAlph == tAlph;  
    }

    public bool IsAnagramGoodSolution(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] counter = new int[26];

        for(int i = 0; i < s.Length; i++) {
            // Pour s, on incrémente
            int index_s = s[i] - 'a';  
            counter[index_s] = counter[index_s] + 1;
            
            // Pour t, on décrémente
            int index_t = t[i] - 'a';
            counter[index_t] = counter[index_t] - 1;
        }

        foreach(var count in counter) {
            if(count != 0)
                return false;
        }

        return true;
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
