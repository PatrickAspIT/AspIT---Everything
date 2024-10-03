//inputs for the selection of events 
let EventList = document.querySelector('.Card-Container')
//Inputs for the smilies
let btn1 = document.querySelector('#btn1');
let btn2 = document.querySelector('#btn2');
let btn3 = document.querySelector('#btn3');
//this is used for the timer in the overlay
let Cooldown = 0;

let EventId = 0;
//this is a test
let EventObject;

//Methods for Posting to Database on button Click
//add A method for this and use the button id for the method
const EventRatingURL = 'https://localhost:7268/api/EventRating';
const GetEventUrl = `https://localhost:7268/api/Event/GetActiveorFutureEvents`;

btn1.addEventListener('click', function (OnClick) {
   OnClick.preventDefault();
   let id = 1;
   AddRating(id);
});
btn2.addEventListener('click', function (OnClick) {
   OnClick.preventDefault();
   let id = 2;
   AddRating(id);
});
btn3.addEventListener('click', function (OnClick) {
   OnClick.preventDefault();
   let id = 3;
   AddRating(id);
});

//this is used to get all Events from the database that has the same date or later

function Setup() {
   let SelectContainer = document.querySelector('.Select-Container')
   let RatingContainer = document.querySelector('.Rating-Container')
   SelectContainer.setAttribute('id', "Hidden")

   RatingContainer.removeAttribute("id", "Hidden")
}

GetEvents()

function GetEvents() {

   const requestOptions =
   {
      method: 'get',
      headers: {
         'Content-Type': 'application/json'
      },
   }


   //stringify the data to be sent
   fetch(GetEventUrl, requestOptions)
      .then(response => {
         if (!response.ok) {
            throw new Error('Network response was not ok');
         }
         return response.text();
      })
      .then(data => {
         let Events = JSON.parse(data);
         console.log(Events)
        //  console.log(Events[0].id);

         Events.forEach(element => {
            if (element != " ") {
               let EventCard = document.createElement('div');
               let text = document.createElement('p')
               EventCard.classList.add("EventCard")
               const formattedDate = new Date(element.date).toLocaleDateString();
              //  console.log("Test: ", element.id);
               text.textContent = element.name + " - (" + formattedDate + ")";
               EventList.appendChild(EventCard);
               EventCard.appendChild(text);

               //works
               EventCard.addEventListener('click', function (OnClick) {
                  OnClick.preventDefault();
                  console.log("tes111t");
                  EventId = element.id;
                  Setup()
                  console.log(EventId)
               });

            }
         });
        //  let EventCard = document.querySelectorAll('.EventCard')
         
         //maybe need this later idk
         EventObject = Events
      })
      .catch(error => {
         console.error('Error:', error);
      });
}

//this is the method that posts the rating to the database
function AddRating(id) {
   const requestOptions = {
      method: 'post',
      headers: {
         'Content-Type': 'application/json'
      },
      body: JSON.stringify({
         //Add A method for to change the EventId
         "EventId": EventId,

         "RatingID": id,
      })
   };
   console.log(EventId);



   fetch(EventRatingURL, requestOptions)
      .then(response => {
         if (!response.ok) {
            throw new Error('Network response was not ok');
         }
         console.log("response: ", response)
         return response.text();
      })
      .then(data => {
        // let Events = JSON.parse(data);
        //  console.log(Events)
      })
      .catch(error => {
         console.error('Error:', error);
      });
   AddOverlay();
}
//This is used to create the overlay so the user gets some feedback to their rating
function AddOverlay() {
   //Cooldown for the overlay to pervent spam
   const Timer = Date.now();

   if (Timer > Cooldown) {


      let text = document.querySelector('.Title');
      let oldText = text.textContent;
      text.textContent = "Tak for dit Feedback!";

      setTimeout(function () {
         console.log(oldText)
         text.textContent = oldText;
      }, 5000);

      //Set the cooldown to the current time + 5 seconds
      Cooldown = Date.now();
      Cooldown = Math.floor(Cooldown + 5000);

      //Used for debuging
      console.log(Cooldown)
      console.log(Math.floor(Timer - Cooldown))
   }
   //If the cooldown is not over, do nothing
   else {
      console.log("Wait Please")
   }

}