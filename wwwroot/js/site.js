﻿/*
 Dorset College Dublin
 BSc in Science in Computing & Multimedia
 Object-Oriented Programming - BSC20921
 Stage 2, Semester 2
 Continuous Assessment 2

 Student Name: Mateus Fonseca Campos
 Student Number: 24088
 Student Email: 24088@student.dorset-college.ie

 Submission date: 8 May 2022
*/

function imageZoom(imgID, resultID) {
    let img, lens, result, cx, cy;
    img = document.getElementById(imgID);
    result = document.getElementById(resultID);
    /* Create lens: */
    lens = document.createElement("DIV");
    lens.setAttribute("class", "img-zoom-lens");
    /* Insert lens: */
    img.parentElement.insertBefore(lens, img);
    /* Calculate the ratio between result DIV and lens: */
    cx = result.offsetWidth / lens.offsetWidth;
    cy = result.offsetHeight / lens.offsetHeight;
    /* Set background properties for the result DIV */
    result.style.backgroundImage = "url('" + img.src + "')";
    result.style.backgroundSize = (img.width * cx) + "px " + (img.height * cy) + "px";
    /* Execute a function when someone moves the cursor over the image, or the lens: */
    lens.addEventListener("mousemove", moveLens);
    img.addEventListener("mousemove", moveLens);
    /* And also for touch screens: */
    lens.addEventListener("touchmove", moveLens);
    img.addEventListener("touchmove", moveLens);

    function moveLens(e) {
        let pos, x, y;
        /* Prevent any other actions that may occur when moving over the image */
        e.preventDefault();
        /* Get the cursor's x and y positions: */
        pos = getCursorPos(e);
        /* Calculate the position of the lens: */
        x = pos.x - (lens.offsetWidth / 2);
        y = pos.y - (lens.offsetHeight / 2);
        /* Prevent the lens from being positioned outside the image: */
        if (x > img.width - lens.offsetWidth) {
            x = img.width - lens.offsetWidth;
        }
        if (x < 0) {
            x = 0;
        }
        if (y > img.height - lens.offsetHeight) {
            y = img.height - lens.offsetHeight;
        }
        if (y < 0) {
            y = 0;
        }
        /* Set the position of the lens: */
        lens.style.left = x + "px";
        lens.style.top = y + "px";
        /* Display what the lens "sees": */
        result.style.backgroundPosition = "-" + (x * cx) + "px -" + (y * cy) + "px";
    }

    function getCursorPos(e) {
        let a, x, y;
        e = e || window.e;
        /* Get the x and y positions of the image: */
        a = img.getBoundingClientRect();
        /* Calculate the cursor's x and y coordinates, relative to the image: */
        x = e.pageX - a.left;
        y = e.pageY - a.top;
        /* Consider any page scrolling: */
        x = x - window.scrollX;
        y = y - window.scrollY;
        return {x: x, y: y};
    }
}