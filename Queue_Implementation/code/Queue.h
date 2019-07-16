/* struct typedefs */
struct node
{
    int data;
    struct node *next;
};
typedef struct node node;

struct queue
{
    int count;
    node *front;
    node *rear;
};
typedef struct queue queue;

/*
function declarations
note: more functions were added for usability
 */
queue* initQueue();
int isEmpty(queue *q);
void enqueue(queue*, int);
int dequeue(queue*);
void printQueue(node *head);
