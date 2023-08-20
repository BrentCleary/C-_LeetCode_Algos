// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function UpdateResult(action)
{
  fetch('/Home/UpdateResult?action=${action}')
    .then(response => response.json())
    .then(data => 
      {
        const resultValueElement = document.getElementById('ResultValue');
        resultValueElement.textContent = data.resultValue;
      });
}
