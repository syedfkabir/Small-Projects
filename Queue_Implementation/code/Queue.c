#include "Queue.h"
#include <stdio.h>
#include <stdlib.h>
#include <assert.h>
/*
  Queue size of 10 predefined, however using linked list implementation
  size is dynamic, and does not need a set size.
  This helped me simplify code, but I realize its not needed,
  You can remove a IF condition in enqueue without the code breaking
*/
#define SIZE 10

/* Simple init function, allocates memory space for ADT Queue & sets values to NULL */
queue* initQueue()
{
    queue *q = malloc(sizeof(queue));
    assert(q);
    q->count = 0;
    q->front = NULL;
    q->rear = NULL;
    return q;
}

/* simple boolean function, returns 1 if nodes next value is NULL */
int isEmpty(queue *q)
{
    return (q->rear == NULL);
}


void enqueue(queue *q, int value)
{
    /*
    Checking to see if the current queue size is under the preset size
    this code is not mandatory, as it is a linked list implementation
    and can dynamically change size.
    */
    if (q->count < SIZE)
    {
        /*
        First we create a temp node to be added to the Queue,
        we must also allocate space of size node, and insert the given
        data value from the function parameter.
        */
        node *tmp;
        tmp = malloc(sizeof(node));
        tmp->data = value;
        tmp->next = NULL;
        if(!isEmpty(q))
        {
            /* This if statement is triggered if there are no items in the queue */
            q->rear->next = tmp;
            q->rear = tmp;
        }
        else
        {
            /*
            If there are items in the queue, set the front of the current queue to be the rear
            and then set the rear as the newly created temp node, making sure to always increment count
            */
            q->front = q->rear = tmp;
        }
        q->count++;
    }
    else
    {
        printf("Queue is full\n");
    }
}

int dequeue(queue *q)
{
    /*
    make a temp node to store the new queue,
    dereference the old front, and asign it to the next front
    make sure to free space and decrease index pointer, count
    */
    node *tmp;
    int n = q->front->data;
    tmp = q->front;
    q->front = q->front->next;
    q->count--;
    free(tmp);
    return(n);
}

/* Simple print statement to view items in queue, using Recursion */
void printQueue(node *head)
{
    if(head == NULL)
    {
        printf(" End of Deli Queue \n \n");
    }
    else
    {
        printf("[ #%d ]-->", head -> data);
        printQueue(head->next);
        /*
        Recursion used here, function fed the next item in the queue;
        with each call, printQueue moves and prints the next item in the queue.
        */
    }
}
