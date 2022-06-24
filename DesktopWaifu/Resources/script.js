let img = "ueqBS0o-min.jpg";

let backgroundIsLoaded = false

//in case of slow network or api out of service
const timeOut = setTimeout( function (){ setBackground(img)}, 2000)

fetch("https://api.waifu.pics/sfw/waifu",
{
    method: "Get",
    headers: {
        "accept": "application/json",
    },
}).then(response => 
    response.json().then(data => ({
        data: data
    })
).then(res => {
    setBackground(res.data.url)
}));

function setBackground(url){
    if (!backgroundIsLoaded) {
        backgroundIsLoaded = true;
        document.body.style.backgroundImage = "url(" + url + ")"   
    }
}