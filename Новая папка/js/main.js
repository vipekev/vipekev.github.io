const list = document.querySelector('.list'),
	items = document.querySelectorAll('.blocks_item')
	listItems = document.querySelectorAll('.list_item')
	
function filter() {
	list.addEventListener('click', event => {
		const targetId = event.target.dataset.id
		const target = event.target
		
		if(target.classList.contains('list_item')) {
			listItems.forEach(listItem => listItem.classList.remove('active'))
			target.classList.add('active')
		}
		
		switch(targetId) {
			case 'all':
				getItems('blocks_item')
				break
			case 'wardrobe':
				getItems(targetId)
				break
			case 'bed':
				getItems(targetId)
				break
			case 'table':
				getItems(targetId)
				break
			case 'sofa':
				getItems(targetId)
				break
		}
	})
}
filter()

function getItems(className) {
	items.forEach(item => {
		if (item.classList.contains(className)) {
			item.style.display = 'flex'
		} else {
			item.style.display = 'none'
		}
	})
}