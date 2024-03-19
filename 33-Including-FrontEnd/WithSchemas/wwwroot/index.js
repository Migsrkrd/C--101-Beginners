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
