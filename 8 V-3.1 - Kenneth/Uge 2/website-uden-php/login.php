<?php
// Start output buffering and session
session_start();
ob_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <title>Login</title>
</head>
<body class="light">

    <?php
    // Define variables and set to empty values
    $userName = $password = "";
    $userNameErr = $passwordErr = "";
    $isValid = true; // To check if validation passed
    $bruger = "patr39323";
    $kode = "X9_YGi5A+]ue";

    if ($_SERVER["REQUEST_METHOD"] == "POST") {

        

        if (empty($_POST["login-username"])) {
            $userNameErr = "Brugernavn er påkrævet";
            $isValid = false;
        } else {
            $userName = test_input($_POST["login-username"]);
            // åbner forbindelsen
            // $mysqli = new mysqli("localhost", $bruger, $kode, "Edea");
            // $result = $mysqli->query("SELECT * FROM users WHERE username = '$userName'");
            // $row = $result->fetch_assoc();
            // echo htmlentities($row['username']);
            }

        if (empty($_POST["login-password"])) {
            $passwordErr = "Adgangskode er påkrævet";
            $isValid = false;
        } else {    
            $password = test_input($_POST["login-password"]);
        }        

        // If both fields are valid, redirect to login-landing.php
        if ($isValid) {
            // Session
            $_SESSION["login-username"] = $_POST["login-username"];

            header("Location: login-landing.php");
            exit; // Always call exit after redirection
        }
    }

    // Function to sanitize input
    function test_input($data) {
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
    }
    ?>

    <?php 
        include "includes/topmenu.php";
        include "includes/sidemenu.php";
    ?>

    <div class="content">
        <main>
        <h1>Login</h1>
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="POST">
            <p>
                <label for="login-username" class="loginform">Brugernavn: </label>
                <input type="text" name="login-username" placeholder="Brugernavn" class="logininput">
                <span class="loginWarning"><?php echo $userNameErr;?></span>
            </p>
            
            <p>
                <label for="login-password" class="loginform">Adgangskode: </label>
                <input type="text" name="login-password" placeholder="Adgangskode" class="logininput">
                <span class="loginWarning"><?php echo $passwordErr;?></span>
            </p>
            
            <p>
                <input type="submit" name="login-submit" value="Login" class="submitbtn loginbtn">
            </p>
        </form>
        </main>

        <?php include "includes/footer.php"; ?>
    </div>
        
</body>
</html>

<?php
// End output buffering and send output to the browser
ob_end_flush();
?>