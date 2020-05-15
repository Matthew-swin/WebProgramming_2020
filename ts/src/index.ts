let form = document.getElementById("daform") as HTMLFormElement;
let dabutton = document.getElementById("dabutton") as HTMLButtonElement;
let elements = document.getElementById("elements") as  HTMLDivElement;
let ffs = document.getElementById("ffs") as HTMLInputElement;

if (ffs == null)
{
    alert("ffs is null")
}
else if (elements == null)
{
    alert("elements is null")
}
else if (dabutton == null) {
    alert("button is null")
}
else {
    dabutton.onclick = function (event) {
        event.preventDefault();

        let MyNewElement = document.createElement("div");
        let MyElementText = (document.createTextNode(ffs.value));
        

        elements.appendChild(MyNewElement);
        MyNewElement.appendChild(MyElementText);

        MyNewElement.onclick = function () {
            MyNewElement.style.background = "green";
        }

    }
}

