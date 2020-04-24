
document.addEventListener('DOMContentLoaded', () => {
    const selectAllCheckbox = document.getElementsByClassName("table__select-all")[0];
    const singleSelectCheckboxes = document.getElementsByClassName("table__select-single");
    const deleteButton = document.getElementsByClassName("delete-btn")[0];
    const blockButton = document.getElementsByClassName("block-btn")[0];
    const unblockButton = document.getElementsByClassName("unblock-btn")[0];

    selectAllCheckbox.addEventListener('click', () => {
        Array.prototype.forEach.call(singleSelectCheckboxes, (checkbox) => {
            checkbox.checked = selectAllCheckbox.checked;
        });
    });  
});