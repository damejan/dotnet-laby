// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(() => {
    const burger = document.querySelector('.burger');
    const nav = document.querySelector(`#${burger.dataset.target}`);

    burger.addEventListener('click', () => {
        burger.classList.toggle('is-active');
        nav.classList.toggle('is-active');
    });
    
    const noteTitle = document.querySelector("#note-title");
    if(noteTitle) {
        const noteContent = document.querySelector("#note-content");
        
        noteContent.innerHTML = DOMPurify.sanitize(marked.parse(noteContent.innerHTML));
    }

})();