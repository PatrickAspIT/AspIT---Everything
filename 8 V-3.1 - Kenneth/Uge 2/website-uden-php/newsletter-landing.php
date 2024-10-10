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
    <title>Edea newsletter-landing</title>
</head>
<body>
    <?php 
        include "includes/topmenu.php";

        include "includes/sidemenu.php";
    ?>

    <div class="content">

        <div class="landingPage">
        <?php
            $firstName = htmlspecialchars($_POST['newsletter-firstname']);

            echo "<h1>Kære $firstName. Du er nu tilmeldt vores nyhedsbrev. Vi glæder os til hver måned at brige dig spændende nyheder fra kunstskøjteløbets verden. Husk, at du altid kan afmelde dig nyhedsbrevet igen ved at følge linket i bunden af nyhedsbrevet. Med venlig hilsen dit Edea team.</h1>";
            ?>
        </div>

        <?php include "includes/footer.php"; ?>

    </div>
</body>
</html>