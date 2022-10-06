pipeline {
	agent none
	
	environment {
		VAL = 'ola'
		BRANCHNAME = $(BRANCH_NAME)
	}
	
	stages {

	}
	
	post {
		success {
			echo 'Sucesso'
		}
		failure {
			echo 'Erro'
		}
	}
}


