all: myProg
myProg: Queue.o TestQueue.o
	gcc Queue.o TestQueue.o -o myProg
Queue.o: Queue.c
	gcc -c Queue.c
TestQueue.o: TestQueue.c
	gcc -c TestQueue.c
clean:
	rm *.o myProg
