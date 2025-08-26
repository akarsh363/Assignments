<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WordValidation.aspx.cs" Inherits="SampleWebFormsApp.WordValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validate Me!</title>

    <script type="text/javascript">
        function validateForm() {
            var username = document.getElementById("username").value.trim();
            var pin = document.getElementById("pin").value.trim();
            var state = document.getElementById("states").value;
            var validatePin = document.getElementById("validatePin").checked;
            var testMe = document.getElementById("testMe").checked;

            var errors = [];

            // Username validation
            if (username.length < 6 || username.length > 8) {
                errors.push("Username not validated");
            }

            // Pin validation
            if (validatePin && pin === "") {
                errors.push("Pin not validated");
            } else if (pin !== "" && !/^[a-zA-Z0-9]+$/.test(pin)) {
                errors.push("Pin not validated");
            }

            // States validation
            if (state === "") {
                errors.push("States not validated");
            }

            // Test Me checkbox message
            errors.push("Test Me is " + (testMe ? "checked" : "unchecked"));

            var selectedItem = document.querySelector('input[name="item"]:checked');
            if (selectedItem) {
                errors.push("Selected item: " + selectedItem.value);
            } else {
                errors.push("No item selected");
            }


            if (errors.length > 0) {
                alert(errors.join("\n"));
                return false;
            }

            return true;

        }
    </script>

</head>
<body>
    <form id="form1" runat="server" onsubmit="return validateForm();">
        <div>
            <h2>Validate Me!</h2>

            <label>Username (6-8 characters):</label><br />
            <input type="text" id="username" /><br />
            <br />

            <label>Pin:</label><br />
            <input type="text" id="pin" /><br />
            <br />

            <label>States:</label><br />
            <select id="states">
                <option value="">--Select--</option>
                <option value="option1">option1</option>
                <option value="option2">option2</option>
            </select><br />
            <br />

            <input type="checkbox" id="validatePin" />
            <label for="validatePin">Validate Pin</label><br />

            <input type="checkbox" id="testMe" />
            <label for="testMe">Test Me</label><br />
            <br />
            <label>Select an item:</label><br />
            <input type="radio" id="milk" name="item" value="Milk" />
            <label for="milk">Milk</label><br />

            <input type="radio" id="cheese" name="item" value="Cheese" />
            <label for="cheese">Cheese</label><br />

            <input type="radio" id="butter" name="item" value="Butter" />
            <label for="butter">Butter</label><br /><br />

            <input type="submit" value="Check Form" />

        </div>
    </form>
</body>
</html>
