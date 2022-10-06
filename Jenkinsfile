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
		stage('build') {
			steps {
				echo '$(BUILD_ID)->$(JOB_NAME):$(BUILD_NAME)'
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


