package com.sdi.client;


import alb.util.menu.BaseMenu;

public class Main extends BaseMenu {
	
	public Main() {
		menuOptions = new Object[][] { 
			{ "Listar usuarios del sistema", ListUsersAction.class },
			{ "Deshabilitar usuario del sistema", CancelUserAction.class }, 
			{ "Listar comentarios y puntuaciones de los viajes ya realizados "
					+ "en el último mes, ordenados de más reciente a menos", 
					ListRatingsAction.class },
			{ "Eliminar comentarios y puntuaciones", DeleteRatingsAction.class },
		};
	}

	public static void main(String[] args) {
		new Main().execute();
	}

}
