## Snyk Technical Assessment


# 1.Explain the difference between a stack and a queue. Provide real life examples of real-life scenarios where each of them are used appropriately.

A `stack` is a data structure that resembles a real-life stack, such as a stack of plates, when we want to get a plate, we always get the plate from the top, that's why a stack is obedient to the `LIFO` (Last In First Out) method, because the plate at the top is the last one that was place.
In Software, a solid example is a text editor, we keep entering characters and when we press the backspace key, the last character is deleted.

A `queue` data structure, resembles a real-life queue, for example a queue in a pharmacy, it respects the `FIFO` (First In First Out) invariant, the first person from the line(queue) is served, after he leaves, the next person from the line is served.
In Software, there could be an application for a Call Center where calls are recieved in a queue, forwrading them by the arrival( time called).

  + The key difference between them is the two principles each respect, when we `pop`(remove) an element from a stack, the last element added to the stack get's removed, while when we `dequeue`(remove) from a queue, the first element that is currently in the queue is removed.
  + In order to add an element to the stack we use `push` to push an element on top of the stack, while we `enqueue` an element to the end of the queue.
  + The stack doesn't have types, while there are different type of queues, for instance, a priority queue, in a priority queue, the value of the element matters and an element can be "more important" than another, thus the queue can be reordered by this importance factor.
  + In a stack, both insertion and deletion occurs at the top of the stack, while for a queue, we add an element at the end of the queue and we remove an element from the beginning.


# 2.What is the difference between an array and a linked list? Provide advantages and disadvantages of each data structure

An `array` is a data structure that allows us to store multiple elements of the same type. It uses a chunk of set size memory where we can fit these elements.Elements can be accessed by their index, representing their position in the array.

A (singly) `linked list`  is a list of `nodes`, a node holds data and a pointer for the next node.They are not neccesarily stored next to each other in memory and it doesn't have a set size, depending on the implementation, a new element can be added either before the first node and/or after the last node.

Advantages / Disadvantages:
  + If we need to be able to add elements at the beginning or end of our data structure, it is advantageous to use a `linked list` because it can be achieved in constant time.We only need to create the node, set it's pointer to the head (or tail) of the linked list(i.e the first node from the list or the last node from the list) and set the head or tail pointer to be the new node.
While for an `array`, we need to shift all elements one position forward, only then we can add an element at the start of the array.
  + Considering `Array` a `static array`, we can add any number of elements to a linked list as long as there is memory, while an array has a fixed size, the linked list providing an advantage from this point of view.
  + If we need to access elements fast, we should use an `array` because elements can be accessed by their index in the array taking constant time, while in a linked list we need to search for the element to access it taking up to linear time, providing an advantage for arrays for this use case.
  + If memory is an issue, an `array` is more beneficial because it has a predefined fix size, and a linked list, along with data, also stores the pointer address of the next node.


# 3.What is HTTP? How is it different from HTTPS?

  + `HTTP` stands for `Hypertext Transfer Protocol` and it is a set of rules of communication between the client and server, when accessing a website, we send an **HTTP request** to the server, it responds with an **HTTP resposne**.
  + `HTTPS` stand for `Hypertext Transfer Protocol Secure`, websites that use *HTTPS* have a greater level of security because the website must have an **SSL**(Secure Socket Layer) certificate.
  + *HTTPS* is different from *HTTP*, while in HTTP data is sent ast plaintext and can be intercepted by other uesrs, *HTTPS* provides encryption of the data and performs checks for identity to make sure the data is sent to the right place.

# 4.Can you give some examples of common HTTP response codes?
  `500` - Server Error
  `404` - Resource requested is not found
  `200` - OK, meaning the request has been executed successfuly
  `201` - Means 'Created'.
  `400` - Bad request
  `401` - Unauthorized
# 5.What is the difference between authorization and authentication?

`Authorization` means "permission", if someone is *authorized* to perform a certain action, it means they have the permision to perform said task.
`Authentication` is the process of verifying the identity of a user, then we are able to check if the user is *authorized* to perform certain tasks.


# 6.How would you explain to a 5-year-old how the WWW works?

The *WWW* means World Wide Web, it is called World Wide because it has all the pages you can imagine from the internet from the anywhere in the world.
There are some rules that the pages need to obey, called *HTTP* so that it won't be cahotic.
The *WWW* contains these web pages, most of them use the same language, "HTML", it stands for Hypertext Markup Language, in this language website can speak trough words or images, or even videos.
This language is useful because every page knows how to show us those images or videos and where to put them.
In order for us to go to a certain page, we need it's address, just like in real life, we need the address to know where to look for that web page, that address in computer terms is called a **URL**, it stands for
Uniform Resource Locator, it got that name because it locates the page we are looking for.
In order to get to the page we want to access or computer asks for it and through the "internet" it is delivered forward to another computer, or if the address is far away from us, many computers, each computer telling the next computer that we asked for that page. If we imagine a real life address, the computer might not know the street but it might know the city, so it can send our message to a computer from that city.From there a computer might even know the address, when we get to the address, the message is recievd by a computer that has the web page we want to access, and then it can respond to us with the details of the web page, sending the message back trough a similar route back to our address.
All of this takes place within the hit of a button.
