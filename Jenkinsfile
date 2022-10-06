pipeline {
	agent none
	
	environment {
		VAL = 'ola'
		BRANCHNAME = $(BRANCH_NAME)
	}
	
	stages {
		stage('checkout') {
			agent any
			steps {
				echo 'checkout do BRANCH->$(env.BRANCHNAME)'
				checkout sm
			}		
		}
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


