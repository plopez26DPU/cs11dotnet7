HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
Console.WriteLine($"Apple's home page has {response.Content.Headers.ContentLength:N0} bytes");