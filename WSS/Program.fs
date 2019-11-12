open System
open Fleck

[<EntryPoint>]
let main argv =
    let server = new WebSocketServer("ws://0.0.0.0:8181")
    server.Start
        (fun socket ->
            socket.OnOpen <- fun () -> Console.WriteLine("Open!")
            socket.OnClose <- fun () -> Console.WriteLine("Close!")
            socket.OnMessage <- fun message -> socket.Send(message) |> ignore
            socket.OnError <- fun (x) -> Console.WriteLine("OnError", x.Message))
    Console.ReadLine() |> ignore
    0
