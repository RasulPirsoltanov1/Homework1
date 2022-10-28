// 4 - Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın (switch case ilə yazın)
let month = "aprel";
switch (month) {
    case "yanvar":
    case "fevral":
    case "mart":
        console.log("Qis")
        break;
    case "aprel":
    case "may":
    case "iyun":
        console.log("Yaz")
        break;
    case "iyul":
    case "avgust":
    case "sentyabr":
        console.log("Yay")
        break;
    case "oktyabr":
    case "dekabr":
    case "noyabr":
        console.log("Payiz")
        break;
    default:
        console.log("ayin adini duzgun girin!")
        break;
}