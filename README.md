# retro-games-store

RetroGamesCache - An eCommerce website

RetroGamesCache is a fully responsive eCommerce website for video games made in 1990s.  Built with ASP.NET Core MVC.

https://retrogamescache.com/


FEATURES:

- Home page displays the products available for purchase from website


- Details page for each product

	* tiered price discount scheme based off quantity ordered


- User Management (Register/Login)

	* Utilizes out the box ASP.NET Core Identity


- User Roles

	* Admin (full access to everything)
	* Employee (able to manage orders Order Management)
	* Customer (basic access, can submit orders, view them in Order Management)
	* Company (deferred payment, after order is shipped, 30 days to make payment)


- Content Management (Available only to Admins)

	* add/remove/edit products
	* add/remove/edit categories
	* add/remove/edit company
	
	* each content page uses datatables to display content (utilizes https://datatables.net/)
	* fancy alerts when deleting content (utilizes https://sweetalert2.github.io/)


- Form validation


- Fancy notifications (utilizes https://codeseven.github.io/toastr/)


- Fully functional Shopping Cart

	* Displays grand total
	* Add/Remove items, adjust quantity
 
 
- Order Summary
	
	* includes user/shipping details (name, address, etc.)


- Stripe integration for payment

	* only sandbox/testing mode,  no real payments can be made through website
	

- Order Management

	* User can see their order details and status
	* Contains Carrier/Tracking info
	* Order status/state (Pending/Approved/Cancelled/Processing/Shipped)
	* For company order, once order is shipped, company can log back in and pay for their order
