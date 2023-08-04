function GetAllStudents()
{

fetch("https://localhost:44363/api/Student").then((response) => {
    return response.json();})
        .then((data) => {
            console.log(data);
            data.forEach(e => {
                for(var i = 0 ; i < data.length ;i++)
                {
                    var tr = document.createElement("tr")
                    
                    var td1 = document.createElement("td");
                    var td2 = document.createElement("td");
                    var td3 = document.createElement("td");
                    var td4 = document.createElement("td");
                    var td5 = document.createElement("td");
                    var td6 = document.createElement("td");
                    var td7 = document.createElement("td");
                    td1.innerHTML=data[i].st_Id;
                    td2.innerHTML=data[i].st_Fname;
                    td3.innerHTML=data[i].st_Lname;
                    td4.innerHTML=data[i].st_Address;
                    td5.innerHTML=data[i].st_Age;
                    td6.innerHTML=data[i].dept_Name;
                    td7.innerHTML=data[i].st_super_Name;
                    tr.append(td1,td2,td3,td4,td5,td6,td7);
                    console.log(tr);
                    tableBody.append(tr);
                }
            });
        })
        .catch((erorr) => console.log(erorr));

}