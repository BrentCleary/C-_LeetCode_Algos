﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// script.js
document.addEventListener("DOMContentLoaded", function () {
  const floatingBar = document.querySelector(".floating-bar");

  // Function to show the floating bar
  function showFloatingBar() {
      const screenHeight = window.innerHeight;
      const scrollY = window.scrollY;

      if (scrollY > screenHeight) {
          floatingBar.style.bottom = "0";
      } else {
          floatingBar.style.bottom = "-50px";
      }
  }

  // Add scroll event listener
  window.addEventListener("scroll", showFloatingBar);

  // Initial check on page load
  showFloatingBar();
});
