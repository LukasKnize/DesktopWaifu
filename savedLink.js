let isOpened = false;

function openSavedLinks() {
    let savedLinks = document.querySelector(".savedLinks");
    let Links = document.querySelector(".links");
    if (isOpened) {
        let links = document.querySelectorAll(".singleLink");
        links.forEach(element => {
            element.remove();
        });
        savedLinks.style.display = "none";
        isOpened = false;
    } else {
        isOpened = true;
        savedLinks.style.display = "block";
        let adress = JSON.parse(localStorage.getItem("urls"));
        let names = JSON.parse(localStorage.getItem("urlName"));
        for (let i = 0; i < adress.length; i++) {
            let getDomainOnly = adress[i].split("/")
            const singleLink = document.createElement('a');
            singleLink.classList.add('singleLink');
            singleLink.href = adress[i];
            const singleLinkImg = document.createElement('img');
            singleLinkImg.src = "https://t3.gstatic.com/faviconV2?client=SOCIAL&type=FAVICON&fallback_opts=TYPE,SIZE,URL&url=http://" + getDomainOnly[2] + "&size=128";
            singleLink.appendChild(singleLinkImg);
            const linkText = document.createElement('p');
            linkText.innerText = names[i];
            singleLink.appendChild(linkText);
            Links.appendChild(singleLink);
        }
    }
}

function addLink() {
    let urlFromInput = document.getElementById("urlInput").value;
    let helper = JSON.parse(localStorage.getItem("urls"));
    let sliceUrl = urlFromInput.split("/");
    if (sliceUrl[0] == "http:" || sliceUrl[0] == "https:") {
        helper.push(urlFromInput);
        localStorage.setItem("urls", JSON.stringify(helper));
        let nameFromInput = document.getElementById("nameInput").value;
        let helper2 = JSON.parse(localStorage.getItem("urlName"));
        helper2.push(nameFromInput);
        localStorage.setItem("urlName", JSON.stringify(helper2));
        let Links = document.querySelector(".links");
        let links = document.querySelectorAll(".singleLink");
        links.forEach(element => {
            element.remove();
        });
        let adress = JSON.parse(localStorage.getItem("urls"));
        let names = JSON.parse(localStorage.getItem("urlName"));
        for (let i = 0; i < adress.length; i++) {
            let getDomainOnly = adress[i].split("/")
            const singleLink = document.createElement('a');
            singleLink.classList.add('singleLink');
            singleLink.href = adress[i];
            const singleLinkImg = document.createElement('img');
            singleLinkImg.src = "https://t3.gstatic.com/faviconV2?client=SOCIAL&type=FAVICON&fallback_opts=TYPE,SIZE,URL&url=http://" + getDomainOnly[2] + "&size=128";
            singleLink.appendChild(singleLinkImg);
            const linkText = document.createElement('p');
            linkText.innerText = names[i];
            singleLink.appendChild(linkText);
            Links.appendChild(singleLink);
            closeAddLink();
        }
    } else {
        document.getElementById("urlLabel").style.color = "red";
    }
}

function openAddLink() {
    let container = document.querySelector(".addAdressContainer");
    container.style.display = "flex"
}

function closeAddLink() {
    let container = document.querySelector(".addAdressContainer");
    container.style.display = "none"
}