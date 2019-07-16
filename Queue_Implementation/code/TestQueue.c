#include <stdio.h>
#include "Queue.h"

  /*
    This set of code emulates the way a line would work at a local supermarket.
    I used the example of customers entering a Metro to buy meat at the Deli.
    Customers at delis usually pull a ticket from a ticket dispenser, and wait for
    their "number to be called". This can be simulated using a queue, as it a ADT that mimics
    real life first come first served "lines". The code also shows how a queue would look if
    certain customers were already served their orders.
  */


int main()
{
    printf("\n");
    queue *q = initQueue();
    printf("Customers enter Metro to order meat from the deli\n");
    printf("they take a number from the ticket dispenser.\n");
    printf("These are the deli order numbers:\n");
    enqueue(q,17);
    enqueue(q,22);
    enqueue(q,33);
    enqueue(q,39);
    enqueue(q,47);
    enqueue(q,55);
    printQueue(q->front);
    printf("These are the deli order numbers\n");
    printf("after 2 customers are served:\n");
    dequeue(q);
    dequeue(q);
    printQueue(q->front);
    return 0;
}
