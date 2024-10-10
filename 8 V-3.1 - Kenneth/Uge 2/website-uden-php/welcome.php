<?php
// Start the session
session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <title>Edea user-landing</title>
</head>
<body>
    <?php 
        include "includes/topmenu.php";

        include "includes/sidemenu.php";
    ?>

    <div class="content">

        <div>
            <?php
              $firstName = $_SESSION["newuser-firstname"];

              echo "<h1>Velkommen til, $firstName. Du kan logge ind her:";            
            ?>
        </div>

        <main>
        <h1>Login</h1>
        <form action="login-landing.php" method="POST">
            <p>
                <label for="login-username" class="loginform">Brugernavn: </label>
                <input type="text" name="login-username" placeholder="Brugernavn" class="logininput">
            </p>
            
            <p>
                <label for="login-password" class="loginform">Adgangskode: </label>
                <input type="text" name="login-password" placeholder="Adgangskode" class="logininput">
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