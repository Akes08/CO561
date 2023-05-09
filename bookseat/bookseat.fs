module bookseat

type Ticket = {seat:int; customer:string} // Constructor

let mutable tickets = [for n in 1..10 -> {seat = n; customer = ""}] // changeable value

//This displayticket function allows the seat number and customer be displayed together
let DisplayTicket () =
    printfn "%-5s %-15s" "Number of Seats" "Customer Name" // Print seats and customers name
    printfn "%-5s %-15s" "_______________---_---_______--" // The display on how the information will look
    for ticket in tickets do
        printfn "  %-5d   %-15s" ticket.seat ticket.customer

let BookSeat (customers:string, seats:int) = 
    let assignCustomer (ticket:Ticket) =
        if ticket.seat = seats then
            { ticket with customer = customers}
        else
            ticket
    tickets <- List.map assignCustomer tickets //books seat for customer


