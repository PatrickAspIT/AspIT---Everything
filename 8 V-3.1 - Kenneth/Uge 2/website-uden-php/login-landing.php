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
    <title>Edea login-landing</title>
</head>
<body>
    <?php 
        include "includes/topmenu.php";

        include "includes/sidemenu.php";
    ?>

    <div class="content">

        <div class="landingPage">
        <?php
            $userName = $_SESSION["login-username"];

            echo "<h1>Kære $userName. Du er nu logget ind.";
            ?>
        </div>

        <?php include "includes/footer.php"; ?>

    </div>
</body>
</html>