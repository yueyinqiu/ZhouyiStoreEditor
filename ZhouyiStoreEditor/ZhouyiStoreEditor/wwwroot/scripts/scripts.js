window.onbeforeunload = (ev) =>
{
    ev.preventDefault();
    return ev.returnValue = "Do you want to leave this site? Data you have entered may not be saved.";
};