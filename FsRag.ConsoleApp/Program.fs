open Microsoft.SemanticKernel


let build () =
    let kernel =
        Kernel
            .CreateBuilder()
            .AddOllamaChatClient("")
            
    
    ()

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
