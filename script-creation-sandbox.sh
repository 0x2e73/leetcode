#!/bin/bash

# 1. Demander le nom de l'exercice
read -p "Nom de l'exercice (ex: ContainsDuplicate) : " DIR

# 2. Valeur par défaut si c'est vide
if [ -z "$DIR" ]; then
    DIR="LeetCode_Sandbox_$(date +%Y%m%d_%H%M)"
fi

# 3. Création du projet
echo "🚀 Initialisation de : $DIR..."
dotnet new console -n "$DIR"

# 4. On entre dans le projet
cd "$DIR"

# 5. Injection du boilerplate ultra-complet
cat <<EOF > Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

/* * ---------------------------------------------------------
 * TEST SANDBOX : $DIR
 * ---------------------------------------------------------
 */

var sol = new Solution();

// --- ZONE DE TEST ---
// int[] nums = {1, 2, 3, 1};
// Console.WriteLine($"Resultat: {sol.ContainsDuplicate(nums)}");


// --- TA SOLUTION LEETCODE ---
public class Solution {
    // Colle ton code ici
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
EOF

echo "✅ Dossier '$DIR' créé avec succès."
echo "💡 Conseil : lance 'code $DIR' pour l'ouvrir direct dans VS Code."