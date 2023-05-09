module account

type Account(accountNumber:string, initialBalance:float) = //constructor
    let mutable balance = initialBalance //changeable value

    member this.AccountNumber = accountNumber
    member this.Balance = balance
    
    //This shows what accounts that will be displayed
    static member accounts =
        [ Account("22012359", 50.0)
          Account("22113399", 80.0)
          Account("22014785", 40.0)
          Account("22156844", 0.0)
          Account("22168974", 250.0)
          Account("22369755", 8.0)]

//This withdraws funds
    member this.Withdrawal(amount:float) = // Data type & Account balance float when it changes
        if amount <= balance then // Passing data
            printfn "Transaction complete" // Print successful transaction
        else
           printfn "Transaction failed, Insufficient funds" // Print out unsuccessful transaction
   
   //This deposits funds
    member this.Deposit(amount:float) = // data type
        balance <- balance + amount // pass data to balance
        
    member this.Print() =
        printfn "Account number: %s, Balance: %f" accountNumber balance // System will print out balance after deposit

let CheckAccount(balance:float) = // Function to check balance
    match balance with
    | b when b < 10.0 -> printfn "Balance is low"
    | b when b >= 10.0 && b <= 100.0 -> printfn "Balance is OK"
    | _ -> printfn "Balance is high" // System outputs when output is matched
