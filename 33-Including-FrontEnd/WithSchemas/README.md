## Connecting to the FrontEnd with our WithSchemas backend

The FrontEnd is a web application that is used to interact with the database.

### Prerequisites
- C# .NET Core 8.0
- Visual Studio Code

### Steps
1. Create a `wwwroot` folder in the `WithSchemas` project.

2. Create a `index.html` file in the `wwwroot` folder.

3. Add the following code to the `index.html` file:
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WithSchemas</title>
    <link rel="stylesheet" href="./style.css">
</head>
<body>
    <h1>Connecting to the Frontend!</h1>
    <div id="info"></div>
    <script src="./index.js"></script>
</body>
</html>
```

4. Run the `WithSchemas` project.

You should see the `Connecting to the Frontend!` message in the browser.

5. Now, let's connect the FrontEnd to the WithSchemas backend.

6. Create a `javascript` file in the `wwwroot` folder.

7. We need to fetch the data we created in the `WithSchemas` project. Since it uses Swagger, we can use the Swagger API to fetch the data.

8. Add the following code to the `javascript` file:
```javascript
fetch("http://localhost:5021/Person")
  .then((response) => response.json())
  .then((data) => {
    for (let i = 0; i < data.length; i++) {
        let person = document.createElement("p");
        person.textContent = data[i].name;
        let div = document.getElementById("info");
        let div2 = document.createElement("div");
        div2.className = "person";
        div2.appendChild(person);

        let age = document.createElement("p");
        age.textContent = data[i].age;
        div2.appendChild(age);

        let address = document.createElement("p");
        address.textContent = data[i].address.city + ", " + data[i].address.state;
        div2.appendChild(address);

        div.appendChild(div2);
    }
  });
```

9. Add the following code to the `style.css` file:
```css
/* Reset default styles */
body, h1, p {
    margin: 0;
    padding: 0;
}

/* Set background color and font styles */
body {
    font-family: Arial, sans-serif;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    background: pink;
}

/* Style the heading */
h1 {
    font-size: 24px;
    color: white;
    margin-bottom: 10px;
    background: Black;
    width: 100%;
    text-align: center;
}

/* Style the paragraph */
p {
    font-size: 16px;
    color: #613;
    margin-bottom: 20px;
}

#info {
    font-size: 12px;
    margin-top: 20px;
}

.person{
    margin: 20px;
    padding: 20px;
    border: 1px solid #000;
}
```

10. Run the `WithSchemas` project.

You should see the data from the `WithSchemas` project in the browser:

![Web Picture](<../../assets/Screenshot 2024-03-19 161633.png>)

11. Now, you have successfully connected the FrontEnd to the WithSchemas backend.

## All Done!

Congratulations! You have successfully connected the FrontEnd to the WithSchemas backend.

All front-end work with C# .NET Core 8.0 must be done in the `wwwroot` folder. This is where the front-end files are served from.

You can now use the FrontEnd to interact with the database.

## Additional Resources

- [C# .NET Core 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Swagger](https://swagger.io/)
- [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API)
- [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)
- [CSS](https://developer.mozilla.org/en-US/docs/Web/CSS)
- [JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
- [FrontEnd](https://developer.mozilla.org/en-US/docs/Learn/Front-end_web_developer)

## Next Steps

In the next tutorial, you will learn how to use Sessions in the WithSchemas backend, as well as connect the FrontEnd to the WithSchemas backend using Sessions.







