       
            function Time() {
                document.getElementById("Time").innerHTML = Date();
            }
       

        
            function Hello() {
                var f = document.getElementById("Hello");

                if (f.innerHTML == "Olá JavaScript!")
                { f.innerHTML = "Hello JavaScript!"; }
                else
                { f.innerHTML = "Olá JavaScript!"; }
            }
        

        
            function Font() {
                var x = document.getElementById("Font");
                if (x.style.fontSize != "25px")
                {
                    x.style.fontSize = "25px";
                    x.style.color = "red";
                }
                else
                {
                    x.style.fontStyle.bold;
                    x.style.fontSize = "15px";
                    x.style.fontFamily = "Verdana";
                    s.style.color = "blue"
                }      
            }
       
            function Submit() {
                var x, text;

                //Get the value of input field with id="texto"
                x = document.getElementById("texto").value;

                //If x is Not a Number or less than one or greater than 10

                if (isNaN(x) || x < 1 || x > 10) {
                    text = "Input Not Valid";
                }
                else {
                    text = "Input OK";
                }
                document.getElementById("rtexto").innerHTML = text;
            }
        