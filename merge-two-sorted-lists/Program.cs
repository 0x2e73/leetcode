// You are given the heads of two sorted linked lists list1 and list2.

// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

// Return the head of the merged linked list.


ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    // 1. Le point d'ancrage 
    ListNode dummy = new ListNode(0);
    
    // 2. l'ouvrier qui va construire la suite
    ListNode current = dummy;

    // 3. La boucle : on compare tant qu'on a deux wagons à comparer
    while (list1 != null && list2 != null) {
        if (list1.val <= list2.val) {
            // "L'ouvrier dit : le prochain wagon sera list1"
            current.next = list1;
            // "Puis l'ouvrier se déplace sur ce nouveau wagon"
            current = current.next;
            // "Puis on avance list1 d'un cran"
            list1 = list1.next;
        } else {
            current.next = list2;
            current = current.next;
            list2 = list2.next;
        }
    }

    // On accroche juste le reste d'un coup.
    if (list1 != null) current.next = list1;
    if (list2 != null) current.next = list2;

    // 5. On retourne quoi ? Pas 'dummy', mais le premier vrai wagon.
    return dummy.next;
}

// expected result = [1,1,2,3,4,4]

//  * Definition for singly-linked list.
class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

