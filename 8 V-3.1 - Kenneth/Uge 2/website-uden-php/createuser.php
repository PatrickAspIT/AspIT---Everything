<?php
// Start the session
session_start();

// Process the form submission before any HTML output
if ($_SERVER['REQUEST_METHOD'] == 'POST') {

    $username = $_POST['newuser-username'];
    $password = $_POST['newuser-password'];
    $passwordrepeat = $_POST['newuser-passwordrepeat'];
    $firstname = $_POST['newuser-firstname'];
    $lastname = $_POST['newuser-lastname'];
    $address = $_POST['newuser-address'];
    $postcode = $_POST['newuser-postcode'];
    $city = $_POST['newuser-city'];
    $country = $_POST['newuser-country'];
    $email = $_POST['newuser-email'];
    $website = $_POST['newuser-website'];
    $country = strtolower($country);
    $isValid = true;
           
    if (empty($username) || empty($password) || empty($passwordrepeat) || empty($firstname) || empty($lastname) || empty($address) || empty($postcode)  || empty($country) || empty($email) ) {
        $missingFields = "alle felter skal udfyldes undtagen hjemmeside";
        $isValid = false;
    }

    if ($isValid) {
        // Session
        $_SESSION["newuser-firstname"] = $firstname;

        // Quality test for postnumber, if the country is Denmark/Danmark
        if ($country == "danmark" || $country == "denmark") {
            if (strlen($postcode) != 4) {
                echo "Postnummeret er ikke 4 cifre langt!";
                $isValid = false;
                exit;
            }
        }

        // Redirect to the welcome page
        header("Location: welcome.php");
        exit;
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <title>Newsletter</title>
</head>
<body class="light">

    <?php 
        include "includes/topmenu.php";
        include "includes/sidemenu.php";
    ?>

    <div class="content">
        <main>
            <h1>Opret bruger</h1>
            <form method="POST">
                <p>
                    <label for="newuser-username">Brugernavn: </label>
                    <input type="text" name="newuser-username" placeholder="Brugernavn" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-password">Adgangskode: </label>
                    <input type="text" name="newuser-password" placeholder="Adgangskode" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-passwordrepeat">Gentag adgangskode: </label>
                    <input type="text" name="newuser-passwordrepeat" placeholder="Gentag adgangskode" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-firstname">Fornavn: </label>
                    <input type="text" name="newuser-firstname" placeholder="Fornavn" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-lastname">Efternavn: </label>
                    <input type="text" name="newuser-lastname" placeholder="Efternavn" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-address">Adresse: </label>
                    <input type="text" name="newuser-address" placeholder="Gade og nr." class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-postcode">Postnummer: </label>
                    <input type="text" name="newuser-postcode" placeholder="Postnummer" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-city">By: </label>
                    <input type="text" name="newuser-city" placeholder="By" disabled class="logininput">
                </p>

                <p>
                    <label for="newuser-country">Land: </label>
                    <input type="text" name="newuser-country" placeholder="Land" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-email">E-mail: </label>
                    <input type="text" name="newuser-email" placeholder="E-mail adresse" class="logininput">
                    <span class="createWarning"><?php echo $missingFields ?></span>
                </p>

                <p>
                    <label for="newuser-website">Website: </label>
                    <input type="text" name="newuser-website" placeholder="Indtast URL på din hjemmeside" class="logininput">
                </p>

                <p>
                    <input type="submit" name="newuser-submit" value="Opret" class="submitbtn">
                </p>
            </form>
        </main>

        <?php include "includes/footer.php"; ?>
    </div>
</body>
</html>
