/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function(head) {

  if(!head || !head.next) {
    return head;
  }

  // starting conditions
  let scout = head.next;
  let current = head;
  let previous = null;


  while(current !== null) {
    current.next = previous;

    // advance all pointers
    previous = current;
    current = scout;
    scout = scout?.next;
  }

  // return previous, as previous is now current(head)
  return previous;

};