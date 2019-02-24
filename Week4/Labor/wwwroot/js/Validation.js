function IsFieldEmpty() {
    if ((document.querySelector("#TxtFName").value === "") ||
        (document.querySelector("#TxtLName").value === "") ||
        (document.querySelector("#TxtSalary").value === "")) {
        return "Required field!";
    }
    return "";
}

function ContainsOnlyLetters() {
    const letters = /^[a-zA-Z]*$/;
    if ((document.querySelector("#TxtFName").value.match(letters)) &&
        (document.querySelector("#TxtLName").value.match(letters))) {
        return "";
    }
    return "Use only letters";
}

function LenghtIsValid() {
    if ((document.querySelector("#TxtFName").value.length > 20) ||
        (document.querySelector("#TxtLName").value.length > 20)) {
        return "Length should be less than 20 characters!";
    }
    return "";
}

const minSalary = 500;
const maxSalary = 50000;

function IsSalaryInValid() {
    if ((isNaN(document.querySelector("#TxtSalary").value))
        || ((document.querySelector("#TxtSalary").value) < minSalary)
        || ((document.querySelector("#TxtSalary").value) > maxSalary)) {
        return `Salary must be between ${minSalary} and ${maxSalary}!`;
    }
    return "";
}

function IsValid() {
    const FieldEmptyEmptyMessage = IsFieldEmpty();
    const OnlyLettersMessage = ContainsOnlyLetters();
    const LengthIsValidMessage = LenghtIsValid();
    const SalaryInvalidMessage = IsSalaryInValid();
    let FinalErrorMessage = "Errors:";

    if (FieldEmptyEmptyMessage !== "")
        FinalErrorMessage += "\n" + FieldEmptyEmptyMessage;
    if (OnlyLettersMessage !== "")
        FinalErrorMessage += "\n" + OnlyLettersMessage;
    if (LengthIsValidMessage !== "")
        FinalErrorMessage += "\n" + LengthIsValidMessage;
    if (SalaryInvalidMessage !== "")
        FinalErrorMessage += "\n" + SalaryInvalidMessage;
    if (FinalErrorMessage !== "Errors:") {
        alert(FinalErrorMessage);
        return false;
    } else {
        return true;
    }
}
